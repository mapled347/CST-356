<template>
    <div id="PersonPage">
        <!-- <p>
            <span>Student Page</span> |
            <span>Home Page</span> |
            <span>Log Off</span> |
        </p> -->
        
        <h2><u>List of People</u></h2>
            
        <table>
            <tr>
                <th>First Name</th>
                <th>Middle Initial</th>
                <th>Last Name</th>
            </tr>
            <tr>
                <td>Stan</td>
                <td>J</td>
                <td>Smith</td>
            </tr>
            <tr>
                <td>Francine</td>
                <td>D</td>
                <td>Smith</td>    
            </tr>
            <tr>
                <td>Steve</td>
                <td>J</td>
                <td>Smith</td>    
            </tr>
            <tr>
                <td>Hayley</td>
                <td>J</td>
                <td>Smith</td>    
            </tr>
            <tr>
                <td>Roger</td>
                <td>A</td>
                <td>Smith</td>    
            </tr>
        </table> 

    </div>
</template>

<script>
export default {
  name: 'Persons',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#PersonPage {
    background-color: lightcoral;
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