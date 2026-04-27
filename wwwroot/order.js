// if orders index.html required date is later than today add the class of overdue to the tr element
document.addEventListener("DOMContentLoaded", function() {   
        const requiredDate = new Date(item.dataset['requireddate']);
        const today = new Date();
        if (requiredDate < today) {
            item.classList.add("overdue");
        }
    });
