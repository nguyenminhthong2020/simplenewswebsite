function loadData(perPage, page, search) {
    $.ajax({
        method: "GET",
        url: `${window.location.origin}/api/category/getlist?perpage=${perPage}&page=${page}&search=${search}`,
        contentType: "application/json",
        dataType: "json",
    })
        .done(function (msg) {
            if (msg != undefined) {
                var tableRef = document.getElementById('tableCategory').getElementsByTagName('tbody')[0];
                tableRef.innerHTML = "";
                for (let i = 0; i < msg.data.length; i++) {
                    var newRow = tableRef.insertRow(tableRef.rows.length);
                    newRow.innerHTML = `<tr>
                    <th scope="row">${msg.data[i].catID}</th>
                    <td id="td_${msg.data[i].catID}">${msg.data[i].catName}</td>
                    <td id="std_${msg.data[i].catID}">${msg.data[i].catStatus == 1 ? "Hiển thị" : "Ẩn"}</td>
                    <td>
                        <i class="bi bi-pencil-square btnEdit"
                           data-bs-toggle="modal"
                                data-bs-target="#exampleModal"
                                data-bs-whatever="mdo"
                                type="button"
                                style="color: blue; margin-right: 20px; transform: scale(1.5, 1.5);"
                                id="${msg.data[i].catID}"
                         >
                        </i>
                        &nbsp;
                         <i class="bi bi-trash btnDelete"
                             data-bs-toggle="modal"
                                data-bs-target="#exampleModal"
                                data-bs-whatever="mdo"
                                type="button"
                                style="color: red; transform: scale(1.5, 1.5);"
                                id="d_${msg.data[i].catID}">
                         </i>
                    </td>
                </tr>`;
                }


                var countPage = msg.all;
                var _select = ``;
                for (let i = 1; i <= countPage; i++) {
                    if (page != i) {
                        _select += `<option value="${i}">${i}</option>`
                    } else {
                        _select += `<option value="${i}" selected>${i}</option>`

                    };
                }
                document.getElementById('pages').innerHTML = "";
                document.getElementById('pages').innerHTML = _select;

                document.getElementById('currentPage').innerText = page;
                if (page == 1) {
                    document.getElementById('prev').classList.add("disabled")

                } else {
                    document.getElementById('prev').classList.remove("disabled")
                }

                if (page == countPage) {
                    document.getElementById('next').classList.add("disabled")
                } else {
                    document.getElementById('next').classList.remove("disabled")
                }
            }

        }).fail(function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus);
        })
}