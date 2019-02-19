<template>
    <div id="StudentPage">
        
        <h2><u>List of Students</u></h2>
            
        <table>
            <thread>
                <tr>
                    <th>Student ID</th>
                    <th>Email Address</th>
                </tr>
            </thread>
            <tbody>
                <tr v-for="student in students">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table> 
     </div>
</template>

<script>
export default {
  name: 'Students',
  mounted () {
      this.students = getStudents();
  },
    data () {
        return {
            students: []
        }
    }
  }

  function getStudents() {
      return JSON.parse(testStudents).students;
  }

  var testStudents = '{"students": [{"studentID": "58412569","email": "lisa.simpson@oit.edu"},{"studentID": "41256325","email": "bart.simpson@oit.edu"},{"studentID": "85796554","email": "marge.simpson@oit.edu"},{"studentID": "85457324","email": "home.simpson@oit.edu"},{"studentID": "65874521","email": "maggie.simpson@oit.edu"}]}'

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#StudentPage {
    background-color: lightgreen;
}

h1 {
    color: white;
    padding-bottom: 10px;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    }

h2 {
    color: rgb(35, 13, 71);
    font-family: Verdana, Geneva, Tahoma, sans-serif;
}

h3 {
    color: white;
    text-align: left;
    font-style: italic;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
}

p {
    color: rgb(35, 13, 71);
    text-align: justify;
    font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
}

table, th, td {
    border: 1px solid black;
    border-collapse: collapse;
    padding: 15px;
}
th {
    text-align: left;
}
td {
    color: rgb(35, 13, 71);
    font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
}
</style>