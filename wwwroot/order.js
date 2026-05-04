// //when overdue radio button is clicked, show only overdue orders
// Attach event listener to each radio button
document.querySelectorAll('input[name="filter"]').forEach(radio => {
    radio.addEventListener('change', event => {
        if (event.target.checked) {
            console.log(`Selected filter: ${event.target.value}`);
            if (event.target.value === "Overdue") {
                document.querySelectorAll('tr').forEach(row => {
                    if (row.classList.contains('overdue')) {
                        row.style.display = '';
                    } else {
                        row.style.display = 'none';
                    }
                });
            } else if (event.target.value === "All") {
                document.querySelectorAll('tr').forEach(row => {
                    row.style.display = '';
                });
            } else if (event.target.value === "CloseToShip") {
                document.querySelectorAll('tr').forEach(row => {
                    if (row.classList.contains('closeToShip')) {
                        row.style.display = '';
                    } else {
                        row.style.display = 'none';
                    }
                });
        } else if (event.target.value === "Default") {
            document.querySelectorAll('tr').forEach(row => {
               if (row.classList.contains('default')) {
                    row.style.display = '';
                } else {
                    row.style.display = 'none'; 
                }
            });
            }
        }
    });
});