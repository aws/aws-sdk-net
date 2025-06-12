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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeContext operation.
    /// </summary>
    public partial class DescribeContextResponse : AmazonWebServiceResponse
    {
        private string _contextArn;
        private string _contextName;
        private string _contextType;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _description;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _lineageGroupArn;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ContextSource _source;

        /// <summary>
        /// Gets and sets the property ContextArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ContextArn
        {
            get { return this._contextArn; }
            set { this._contextArn = value; }
        }

        // Check to see if ContextArn property is set
        internal bool IsSetContextArn()
        {
            return this._contextArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContextName. 
        /// <para>
        /// The name of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string ContextName
        {
            get { return this._contextName; }
            set { this._contextName = value; }
        }

        // Check to see if ContextName property is set
        internal bool IsSetContextName()
        {
            return this._contextName != null;
        }

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// The type of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ContextType
        {
            get { return this._contextType; }
            set { this._contextType = value; }
        }

        // Check to see if ContextType property is set
        internal bool IsSetContextType()
        {
            return this._contextType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the context was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
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
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the context was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lineage group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string LineageGroupArn
        {
            get { return this._lineageGroupArn; }
            set { this._lineageGroupArn = value; }
        }

        // Check to see if LineageGroupArn property is set
        internal bool IsSetLineageGroupArn()
        {
            return this._lineageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A list of the context's properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the context.
        /// </para>
        /// </summary>
        public ContextSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}