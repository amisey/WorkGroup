import React from 'react'
import ReactDom from 'react-dom'

export class Menu extends React.Component {

    constructor(props) {

        super(props);

        this.state = { menues: [] };
    }

    componentDidMount() {
        fetch('/Api/Menu')
            .then((data) => data.json())
            .then((response) => this.setState({ menues: response }));
    }

    renderChildren(menuItem) {
        return (

            <li key={menuItem.Id} className="nav-item dropdown">
                <a className="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    {menuItem.Title}
                </a>
                <div className="dropdown-menu" aria-labelledby="navbarDropdown">
                    {
                        menuItem.Children.map((item) => {
                            return <a className="nav-link" key={item.Id}>{item.Title}</a>
                        })
                    }
                </div>
            </li>
        )
    }

    render() {

        let items = [];

        this.state.menues.map((menuItem) => {

            if (menuItem.Children.length > 0) {
                items.push(this.renderChildren(menuItem))
            }
            else {
                items.push(
                    <li key={menuItem.Id} className="nav-item">
                        <a className="nav-link" key={menuItem.Id}>{menuItem.Title}</a>
                    </li>
                )
            }
        });

        return (
            <ul className="navbar-nav bd-navbar-nav flex-row">
                {items}
            </ul>
        )
    }
}