<template>
  <div id="HomePage">

        <h1 id="HomePageHeader">
            <u>CST 356: LAB 4</u>
        </h1>
             
        <img src="../assets/grocery_cart_kids_2018-07.jpg" alt="Grocery Cart Kids">
        
        <hr>

        <h3>
            Paragraph 1
        </h3>

        <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam consectetur ullamcorper placerat. Proin consectetur elementum ante vel aliquam. 
            Praesent aliquam tempor dapibus. Nam dapibus orci vitae mauris congue vulputate. Aliquam cursus euismod dolor, vitae faucibus neque. Nulla facilisi. 
            Vivamus lacus neque, varius id tincidunt sit amet, suscipit vel urna. Donec sed pulvinar velit. Interdum et malesuada fames ac ante ipsum primis in 
            faucibus. Vestibulum quis sem in lacus vehicula semper eget eu mauris.
        </p>
        
        <hr>

        <h3>
            Paragraph 2
        </h3>

        <p>
            Aenean auctor metus non urna efficitur pharetra. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras at nisi dolor. Sed vitae finibus odio.
            Nulla facilisi. Quisque ullamcorper, nunc a rutrum tristique, ipsum ligula rhoncus justo, nec tempus ligula nulla at erat. Quisque lacinia feugiat 
            bibendum. Cras in ultricies nisl. Quisque aliquam ipsum quis metus interdum dapibus. Sed imperdiet mi eu massa malesuada, ac tincidunt est iaculis. 
            Etiam lobortis dui tortor, vehicula dignissim diam dapibus sed.
        </p>
        
        <hr>

        <h3>
            Paragraph 3
        </h3>

        <p>
            Aenean tempor augue tortor, id dictum ex porta vel. Aliquam luctus augue eu ligula imperdiet ullamcorper. Maecenas et risus blandit massa scelerisque 
            tincidunt non id risus. Maecenas elementum maximus metus. Morbi vitae sem vitae leo suscipit fringilla quis quis tellus. Proin eros tellus, gravida 
            in orci eu, pulvinar sollicitudin leo. Phasellus commodo enim at ornare cursus. Morbi sit amet hendrerit nisi, eget tempor erat. Nam blandit tellus 
            diam, in dictum odio finibus id. Nullam nibh erat, tempus fermentum finibus et, pellentesque lacinia diam. Sed id nisl nec ligula elementum faucibus. 
            Proin aliquam molestie augue at vehicula. Vestibulum scelerisque eu sapien at egestas.
        </p>
        <hr>
  </div>

</template>

<script>
export default {
  name: 'Home',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#HomePageHeader {
    color: lightpink;
    font-size: 35px;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

#LogInPage {
    background-color: lightblue;
}

#HomePage {
    background-color:rgb(137, 137, 206);
}

#StudentPage {
    background-color: lightgreen;
}

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
