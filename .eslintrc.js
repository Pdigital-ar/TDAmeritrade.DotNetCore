module.exports = {
  "rules": {
    "indent": ["warn", 2, { "SwitchCase": 1 }],
    "linebreak-style": ["error", "windows"],
    "quotes": ["error", "double"],
    "semi": ["error", "always"],
    "comma-dangle": ["warn", {
      "arrays": "never",
      "objects": "always",
      "imports": "never",
      "exports": "never",
      "functions": "never",
    }],
  },

  "parserOptions": {
    "ecmaVersion": 2017
  },

  "env": {
    "es6": true
  },
}