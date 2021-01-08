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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the GetContainerPolicy operation.
    /// Retrieves the access policy for the specified container. For information about the
    /// data that is included in an access policy, see the <a href="https://aws.amazon.com/documentation/iam/">AWS
    /// Identity and Access Management User Guide</a>.
    /// </summary>
    public partial class GetContainerPolicyRequest : AmazonMediaStoreRequest
    {
        private string _containerName;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

    }
}