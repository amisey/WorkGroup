const path = require('path');

module.exports = {
    entry: ['./Areas/Amir/Content/Scripts/Component/Index.js'],
    output: {
        path: path.resolve(__dirname, './Areas/Amir/Content/Scripts/Component/Build'),
        filename: 'bundle.js'
    },
    // IMPORTANT NOTE: If you are using Webpack 2, replace "loaders" with "rules"
    module: {
        rules: [
            {
                loader: 'babel-loader',
                test: /\.js$/,
                exclude: /node_modules/,
                query:
                {
                    presets: ['react']
                }
            }
        ]
    }
}