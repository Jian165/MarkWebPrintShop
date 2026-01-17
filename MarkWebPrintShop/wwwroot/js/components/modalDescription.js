document.addEventListener('DOMContentLoaded',() =>{
    const descriptionModal = document.getElementById("descriptionModal");
    const modalTitle = document.getElementById('modalTitle')
    const modalDescription = document.getElementById('modalBody')

    if(!descriptionModal) {console.error("no Modal!");}

    descriptionModal.addEventListener('show.bs.modal', event =>{
        const triggerRow = event.relatedTarget;

        const description  = triggerRow.getAttribute('data-description');
        const serviceName = triggerRow.getAttribute('data-service-name');
        
        modalTitle.textContent = `Description: ${serviceName}`
        modalDescription.textContent = description 
    })
})