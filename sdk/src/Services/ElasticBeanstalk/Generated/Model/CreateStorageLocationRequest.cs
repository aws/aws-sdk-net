/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStorageLocation operation.
    /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
    /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
    /// this API the first time you create an environment in a region. If the storage location
    /// already exists, <code>CreateStorageLocation</code> still returns the bucket name but
    /// does not create a new bucket.
    /// </summary>
    public partial class CreateStorageLocationRequest : AmazonElasticBeanstalkRequest
    {

    }
}