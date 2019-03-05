<template>
    <div id="LogInPage">
        <h1>Login</h1>
        <form>
            <div class='form-entry'>
                Username: <input type='text' v-model='username'/>
            </div>

            <div class='form-entry'>
                Password: <input type='text' v-model='password'/>
            </div>

            <div class='form-entry'>
                <input type='button' value='Submit' v-on:click='submitLogin'/>
            </div>
        </form>

        <div>{{error}}</div>
    </div>
</template>

<script>
    export default {
        name: 'Login',
        methods: {
            submitLogin: function() {
                if (this.username.length == 0) {
                    this.error = "Username must be entered.";
                    return;
                }
                if (this.password.length == 0) {
                    this.error = "Username must be entered.";
                    return;
                }
                alert('Logging in...');
            }
        },
        data () {
            return {
                username: '',
                password: '',
                error: ''
            }
        }
    }
</script>

<style scoped>
#LogInPage {
    background-color: lightblue;
}
</style>