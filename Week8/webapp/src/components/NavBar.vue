<template>
  <div class="menu-bar">
      <span class="menu-item" v-on:click='goToHome'>Home</span> |
      <span class="menu-item" v-on:click='goToPersons'>Persons</span> |
      <span class="menu-item" v-on:click='goToStudents'>Students</span> |
      <span class="menu-item" v-on:click='goToLogin'>Log Off</span>
  </div>
</template>

<script>
export default {
  name: 'NavBar',
  methods: {
    goToHome: function() {
      this.$router.push({ path: 'home' })
    },
    goToPersons: function() {
      this.$router.push({ path: 'persons' })
    },
    goToStudents: function() {
      this.$router.push({ path: 'students' })
    },
    goToLogin: function() {
      this.$router.push({ path: 'login' })
    }
  }
}
</script>

<style scoped>
    .menu-item {
        margin-right: 10px;
        padding: 5px;
    }
    .menu-bar {
        background-color: cyan;
        height: 40px;
        margin-top: 10px;
        vertical-align: middle;
        padding-top: 20px;
        width: 50%;
    }
</style>