<template>
    <div>
        <h2 class='section-heading'>Persons</h2>
        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Name</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons" :key="person.id">
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.middleName }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Persons',
        
        data () {
            return {
                persons: []
            }
        },
        methods: {
            getPersons: function() {
                let personsApi = process.env.PERSON_API;
                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response)
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getPersons();
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