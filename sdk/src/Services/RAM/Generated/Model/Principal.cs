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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes a principal for use with Resource Access Manager.
    /// </summary>
    public partial class Principal
    {
        private DateTime? _creationTime;
        private bool? _external;
        private string _id;
        private DateTime? _lastUpdatedTime;
        private string _resourceShareArn;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the principal was associated with the resource share.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property External. 
        /// <para>
        /// Indicates the relationship between the Amazon Web Services account the principal belongs
        /// to and the account that owns the resource share:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>True</c> – The two accounts belong to same organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>False</c> – The two accounts do not belong to the same organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? External
        {
            get { return this._external; }
            set { this._external = value; }
        }

        // Check to see if External property is set
        internal bool IsSetExternal()
        {
            return this._external.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the principal that can be associated with a resource share.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the association between the resource share and the principal
        /// was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of a resource share the principal is associated with.
        /// </para>
        /// </summary>
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

    }
}