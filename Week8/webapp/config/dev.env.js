'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  PERSON_API: '"http://localhost:5000/api/persons"',
  STUDENT_API: '"http://localhost:5000/api/students"'
})
