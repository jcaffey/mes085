# sample output

```shell
Sending request: profile_id=94100010520200000119&profile_key=BVqARtYICGVFaYiCDBVswkYrNSACUUkD&transaction_type=A&card_exp_date=1022&transaction_amount=0.00&card_number=4485317822240309
Response: (HTTP 200 - 1967ms) transaction_id=b7b05eb7b27136ac80b15577597ec92a&error_code=085&auth_response_text=Card Ok&avs_result=0&auth_code=T6640H
--------------------------------------------------------
Error code with VERIFY (A) and amount 0.00:
085
--------------------------------------------------------
Sending request: profile_id=94100010520200000119&profile_key=BVqARtYICGVFaYiCDBVswkYrNSACUUkD&transaction_type=D&card_exp_date=1022&transaction_amount=0.85&card_number=4485317822240309
Response: (HTTP 200 - 1127ms) transaction_id=3b59098ea5583ecd8f3c6499770c456c&error_code=000&auth_response_text=Approval T6641H&avs_result=0&auth_code=T6641H
--------------------------------------------------------
Error code with SALE (D) and amount 0.85:
000
--------------------------------------------------------
Sending request: profile_id=94100010520200000119&profile_key=BVqARtYICGVFaYiCDBVswkYrNSACUUkD&transaction_type=Z
Response: (HTTP 200 - 496ms) transaction_id=e64bc4a7323d45b79b9df995bab68912&error_code=000&auth_response_text=Empty Batch
--------------------------------------------------------
Error code with BATCHCLOSE (Z)
000
--------------------------------------------------------
Sending request: profile_id=94100010520200000119&profile_key=BVqARtYICGVFaYiCDBVswkYrNSACUUkD&transaction_type=U&transaction_id=e64bc4a7323d45b79b9df995bab68912
Response: (HTTP 200 - 460ms) transaction_id=d2a744fbe2c14b6e8cd8f93312a5c082&error_code=201&auth_response_text=Invalid Transaction ID
--------------------------------------------------------
Error code with REFUND (U):
201
--------------------------------------------------------
```
