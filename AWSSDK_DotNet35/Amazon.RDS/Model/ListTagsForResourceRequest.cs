/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// <para> Lists all tags on an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a
    /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html" >Tagging Amazon RDS Resources</a> .</para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonRDSRequest
    {
        private string resourceName;


        /// <summary>
        /// The Amazon RDS resource with tags to be listed. This value is an Amazon Resource Name (ARN). For information about creating an ARN, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html#USER_Tagging.ARN"> Constructing an RDS Amazon Resource Name
        /// (ARN)</a>.
        ///  
        /// </summary>
        public string ResourceName
        {
            get { return this.resourceName; }
            set { this.resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this.resourceName != null;
        }

    }
}
    
