﻿import React from 'react'
import ReactDom from 'react-dom'

class Test extends React.Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>hi amir</div>
        )
    }
}

ReactDom.render(<Test />, document.getElementById('app'));