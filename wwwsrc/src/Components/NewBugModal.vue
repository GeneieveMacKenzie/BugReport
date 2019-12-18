<template>
    <div class="new-bug-modal">
          <div id="new-bug-modal" class="modal" tabindex="2" role="dialog">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Create Bug</h5>
          <button type="button" class="close" data-dismiss="modal" aria-label="Close">
            <span aria-hidden="true">&times;</span>
          </button>
        </div>
        <div class="modal-body">
          <form @submit.prevent="addBug()">
            <div class="form-group">
              <input
                type="text"
                class="form-control"
                id="name"
                placeholder="Enter Bug Title Here"
                v-model="newBug.Title"
                required
              />
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
          </form>
        </div>
      </div>
    </div>
  </div>


    </div>
</template>


<script>
export default {
    name: 'new-bug-modal',
    data(){
        return {
            newBug: {}
        }
    },
    computed:{},
    methods:{
        addBug(){
            this.$store.dispatch("addBug", this.newBug)
        }
    },
    components:{}
}
</script>


<style scoped>

</style>