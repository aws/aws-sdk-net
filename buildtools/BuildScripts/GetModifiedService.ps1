Process
{
        #list contains the list of services modified
        #if Core has been modified, the list is overwritten to include just the entry 'Core'
        $service_list = @()
        $changed_files = git diff --name-only master github/master
        foreach($filepath in $changed_files)
        {
            if($filepath -match 'sdk/src/Services/')
            {
                $path = $filepath.Split('/')
                if($service_list -notcontains $path[3])
                {
                    $service_list+=,$path[3]
                }
            }
            elseif($filepath -match 'sdk/src/Core/')
            {
                $service_list='Core'
                break
            }
        }
        $service_list
}
