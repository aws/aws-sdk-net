Then(/^I wait to see "([^"]*)" on textview with id "([^"]*)"$/) do |text, id|
    wait_for(timeout:3600,
             timeout_message:"Tests timed out",
             screenshot_on_error:true) do
        query("textview id:'#{id}'","text").first.length > 0
    end
    unless query("android.widget.TextView id:'#{id}'", "text").first =="#{text}"
        screenshot_embed()
		raise("test failed")
    end
end