<template>
  <div class="home">
    <h1>Welcome Home {{user.username}}</h1>
    <button v-if="user.id" @click="logout">logout</button>
    <router-link v-else :to="{name: 'login'}">Login</router-link>
    <Bug/>
    <NewBugModal/>
  </div>
</template>

<script>
import Bug from "../Components/Bug"
import NewBugModal from "../Components/NewBugModal"
export default {
  name: "home",
  computed: {
    user() {
      return this.$store.state.user;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  },
  components:{Bug, NewBugModal}
};
</script>