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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A summary of ID namespaces.
    /// </summary>
    public partial class IdNamespaceSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private string _idNamespaceArn;
        private string _idNamespaceName;
        private IdNamespaceType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the ID namespace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IdNamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdNamespaceArn
        {
            get { return this._idNamespaceArn; }
            set { this._idNamespaceArn = value; }
        }

        // Check to see if IdNamespaceArn property is set
        internal bool IsSetIdNamespaceArn()
        {
            return this._idNamespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdNamespaceName. 
        /// <para>
        /// The name of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IdNamespaceName
        {
            get { return this._idNamespaceName; }
            set { this._idNamespaceName = value; }
        }

        // Check to see if IdNamespaceName property is set
        internal bool IsSetIdNamespaceName()
        {
            return this._idNamespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of ID namespace. There are two types: <c>SOURCE</c> and <c>TARGET</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>SOURCE</c> contains configurations for <c>sourceId</c> data that will be processed
        /// in an ID mapping workflow. 
        /// </para>
        ///  
        /// <para>
        /// The <c>TARGET</c> contains a configuration of <c>targetId</c> to which all <c>sourceIds</c>
        /// will resolve to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdNamespaceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the ID namespace was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}