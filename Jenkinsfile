pipeline {
    agent {label 'master'}
    stages {
        stage('test') {
            steps {
                sh "echo running tests"
            }
        }
        stage('build') {
            steps {
                sh "echo Building App"
            }
        }
        stage('deploy') {
           steps {
                sh "echo deploying"
            }
        }
    }
   }