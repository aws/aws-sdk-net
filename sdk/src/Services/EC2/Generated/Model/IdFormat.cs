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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the ID format for a resource.
    /// </summary>
    public partial class IdFormat
    {
        private DateTime? _deadline;
        private string _resource;
        private bool? _useLongIds;

        /// <summary>
        /// Gets and sets the property Deadline. 
        /// <para>
        /// The date in UTC at which you are permanently switched over to using longer IDs. If
        /// a deadline is not yet available for this resource type, this field is not returned.
        /// </para>
        /// </summary>
        public DateTime? Deadline
        {
            get { return this._deadline; }
            set { this._deadline = value; }
        }

        // Check to see if Deadline property is set
        internal bool IsSetDeadline()
        {
            return this._deadline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property UseLongIds. 
        /// <para>
        /// Indicates whether longer IDs (17-character IDs) are enabled for the resource.
        /// </para>
        /// </summary>
        public bool? UseLongIds
        {
            get { return this._useLongIds; }
            set { this._useLongIds = value; }
        }

        // Check to see if UseLongIds property is set
        internal bool IsSetUseLongIds()
        {
            return this._useLongIds.HasValue; 
        }

    }
}