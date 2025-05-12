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
    /// Lists a summary of the properties of a lineage group. A lineage group provides a group
    /// of shareable lineage entity resources.
    /// </summary>
    public partial class LineageGroupSummary
    {
        private DateTime? _creationTime;
        private string _displayName;
        private DateTime? _lastModifiedTime;
        private string _lineageGroupArn;
        private string _lineageGroupName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the lineage group summary.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the lineage group summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time of the lineage group summary.
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
        /// The Amazon Resource Name (ARN) of the lineage group resource.
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
        /// Gets and sets the property LineageGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the lineage group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string LineageGroupName
        {
            get { return this._lineageGroupName; }
            set { this._lineageGroupName = value; }
        }

        // Check to see if LineageGroupName property is set
        internal bool IsSetLineageGroupName()
        {
            return this._lineageGroupName != null;
        }

    }
}