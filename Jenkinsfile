pipeline {
    agent {label 'master'}
    stages {
        stage('test') {
            steps {
                echo "Robin did it"
                sh "echo running tests"
                sh "hostname"
                sh "uptime"
                sh "df -h"
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