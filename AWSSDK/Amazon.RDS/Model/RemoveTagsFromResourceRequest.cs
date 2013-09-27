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
    /// Container for the parameters to the RemoveTagsFromResource operation.
    /// <para> Removes metadata tags from a DB Instance.</para> <para>For an overview on tagging DB Instances, see DB Instance Tags. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.RemoveTagsFromResource"/>
    public class RemoveTagsFromResourceRequest : AmazonWebServiceRequest
    {
        private string resourceName;
        private List<string> tagKeys = new List<string>();

        /// <summary>
        /// The DB Instance the tags will be removed from. This value is an Amazon Resource Name (ARN). For information about creating an ARN, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html#USER_Tagging.ARN"> Constructing an RDS Amazon Resource Name
        /// (ARN)</a>.
        ///  
        /// </summary>
        public string ResourceName
        {
            get { return this.resourceName; }
            set { this.resourceName = value; }
        }

        /// <summary>
        /// Sets the ResourceName property
        /// </summary>
        /// <param name="resourceName">The value to set for the ResourceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsFromResourceRequest WithResourceName(string resourceName)
        {
            this.resourceName = resourceName;
            return this;
        }
            

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this.resourceName != null;
        }

        /// <summary>
        /// The tag key (name) of the tag to be removed.
        ///  
        /// </summary>
        public List<string> TagKeys
        {
            get { return this.tagKeys; }
            set { this.tagKeys = value; }
        }
        /// <summary>
        /// Adds elements to the TagKeys collection
        /// </summary>
        /// <param name="tagKeys">The values to add to the TagKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsFromResourceRequest WithTagKeys(params string[] tagKeys)
        {
            foreach (string element in tagKeys)
            {
                this.tagKeys.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TagKeys collection
        /// </summary>
        /// <param name="tagKeys">The values to add to the TagKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsFromResourceRequest WithTagKeys(IEnumerable<string> tagKeys)
        {
            foreach (string element in tagKeys)
            {
                this.tagKeys.Add(element);
            }

            return this;
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this.tagKeys.Count > 0;
        }
    }
}
    
