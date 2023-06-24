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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A set of filters to narrow the set of lineage entities connected to the <code>StartArn</code>(s)
    /// returned by the <code>QueryLineage</code> API action.
    /// </summary>
    public partial class QueryFilters
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private List<string> _lineageTypes = new List<string>();
        private DateTime? _modifiedAfter;
        private DateTime? _modifiedBefore;
        private Dictionary<string, string> _properties = new Dictionary<string, string>();
        private List<string> _types = new List<string>();

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) after the create
        /// date.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) by created date.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineageTypes. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) by the type
        /// of the lineage entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4)]
        public List<string> LineageTypes
        {
            get { return this._lineageTypes; }
            set { this._lineageTypes = value; }
        }

        // Check to see if LineageTypes property is set
        internal bool IsSetLineageTypes()
        {
            return this._lineageTypes != null && this._lineageTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAfter. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) after the last
        /// modified date.
        /// </para>
        /// </summary>
        public DateTime ModifiedAfter
        {
            get { return this._modifiedAfter.GetValueOrDefault(); }
            set { this._modifiedAfter = value; }
        }

        // Check to see if ModifiedAfter property is set
        internal bool IsSetModifiedAfter()
        {
            return this._modifiedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedBefore. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) before the last
        /// modified date.
        /// </para>
        /// </summary>
        public DateTime ModifiedBefore
        {
            get { return this._modifiedBefore.GetValueOrDefault(); }
            set { this._modifiedBefore = value; }
        }

        // Check to see if ModifiedBefore property is set
        internal bool IsSetModifiedBefore()
        {
            return this._modifiedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code>(s) by a set if
        /// property key value pairs. If multiple pairs are provided, an entity is included in
        /// the results if it matches any of the provided pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// Filter the lineage entities connected to the <code>StartArn</code> by type. For example:
        /// <code>DataSet</code>, <code>Model</code>, <code>Endpoint</code>, or <code>ModelDeployment</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

    }
}