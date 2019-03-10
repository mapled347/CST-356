<template>
    <div>
        <h2 class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Student ID</th>
                    <th>Email Address</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" :key="student.id">
                    <td>{{ student.studentID }}</td>
                    <td>{{ student.emailAddress }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: []
            }
        },
        methods: {
            getStudents: function() {
                let studentsApi = process.env.STUDENT_API;
                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response)
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getStudents();
        }
    }
</script>

<style scoped>
    table {
        border-collapse: collapse;
    }
    table, th, td {
        border: 1px solid black;
        padding: 10px;
    }
</style>