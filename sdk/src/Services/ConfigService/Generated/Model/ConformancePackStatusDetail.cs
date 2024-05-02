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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Status details of a conformance pack.
    /// </summary>
    public partial class ConformancePackStatusDetail
    {
        private string _conformancePackArn;
        private string _conformancePackId;
        private string _conformancePackName;
        private ConformancePackState _conformancePackState;
        private string _conformancePackStatusReason;
        private DateTime? _lastUpdateCompletedTime;
        private DateTime? _lastUpdateRequestedTime;
        private string _stackArn;

        /// <summary>
        /// Gets and sets the property ConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of comformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConformancePackArn
        {
            get { return this._conformancePackArn; }
            set { this._conformancePackArn = value; }
        }

        // Check to see if ConformancePackArn property is set
        internal bool IsSetConformancePackArn()
        {
            return this._conformancePackArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackId. 
        /// <para>
        /// ID of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConformancePackId
        {
            get { return this._conformancePackId; }
            set { this._conformancePackId = value; }
        }

        // Check to see if ConformancePackId property is set
        internal bool IsSetConformancePackId()
        {
            return this._conformancePackId != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackState. 
        /// <para>
        /// Indicates deployment status of conformance pack.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the conformance pack to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE_IN_PROGRESS when a conformance pack creation is in progress for an account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_COMPLETE when a conformance pack has been successfully created in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED when a conformance pack creation failed in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_IN_PROGRESS when a conformance pack deletion is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED when a conformance pack deletion failed in your account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConformancePackState ConformancePackState
        {
            get { return this._conformancePackState; }
            set { this._conformancePackState = value; }
        }

        // Check to see if ConformancePackState property is set
        internal bool IsSetConformancePackState()
        {
            return this._conformancePackState != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackStatusReason. 
        /// <para>
        /// The reason of conformance pack creation failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string ConformancePackStatusReason
        {
            get { return this._conformancePackStatusReason; }
            set { this._conformancePackStatusReason = value; }
        }

        // Check to see if ConformancePackStatusReason property is set
        internal bool IsSetConformancePackStatusReason()
        {
            return this._conformancePackStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateCompletedTime. 
        /// <para>
        /// Last time when conformation pack creation and update was successful.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateCompletedTime
        {
            get { return this._lastUpdateCompletedTime; }
            set { this._lastUpdateCompletedTime = value; }
        }

        // Check to see if LastUpdateCompletedTime property is set
        internal bool IsSetLastUpdateCompletedTime()
        {
            return this._lastUpdateCompletedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateRequestedTime. 
        /// <para>
        /// Last time when conformation pack creation and update was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateRequestedTime
        {
            get { return this._lastUpdateRequestedTime; }
            set { this._lastUpdateRequestedTime = value; }
        }

        // Check to see if LastUpdateRequestedTime property is set
        internal bool IsSetLastUpdateRequestedTime()
        {
            return this._lastUpdateRequestedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of CloudFormation stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string StackArn
        {
            get { return this._stackArn; }
            set { this._stackArn = value; }
        }

        // Check to see if StackArn property is set
        internal bool IsSetStackArn()
        {
            return this._stackArn != null;
        }

    }
}