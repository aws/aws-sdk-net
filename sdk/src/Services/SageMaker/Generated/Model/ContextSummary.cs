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
    /// Lists a summary of the properties of a context. A context provides a logical grouping
    /// of other entities.
    /// </summary>
    public partial class ContextSummary
    {
        private string _contextArn;
        private string _contextName;
        private string _contextType;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
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