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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains an optional comment and the changes that you want to make with a change batch request.</para>
    /// </summary>
    public class ChangeBatch
    {
        
        private string comment;
        private List<Change> changes = new List<Change>();

        /// <summary>
        /// <i>Optional:</i> Any comments you want to include about a change batch request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ChangeBatch WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }

        /// <summary>
        /// A complex type that contains one <c>Change</c> element for each resource record set that you want to create or delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Change> Changes
        {
            get { return this.changes; }
            set { this.changes = value; }
        }
        /// <summary>
        /// Adds elements to the Changes collection
        /// </summary>
        /// <param name="changes">The values to add to the Changes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ChangeBatch WithChanges(params Change[] changes)
        {
            foreach (Change element in changes)
            {
                this.changes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Changes collection
        /// </summary>
        /// <param name="changes">The values to add to the Changes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ChangeBatch WithChanges(IEnumerable<Change> changes)
        {
            foreach (Change element in changes)
            {
                this.changes.Add(element);
            }

            return this;
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this.changes.Count > 0;
        }
    }
}
