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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A summary of metadata for a common control.
    /// </summary>
    public partial class CommonControlSummary
    {
        private string _arn;
        private DateTime? _createTime;
        private string _description;
        private AssociatedDomainSummary _domain;
        private DateTime? _lastUpdateTime;
        private string _name;
        private AssociatedObjectiveSummary _objective;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the common control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=41, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the common control was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the common control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain that the common control belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociatedDomainSummary Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time when the common control was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the common control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Objective. 
        /// <para>
        /// The objective that the common control belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociatedObjectiveSummary Objective
        {
            get { return this._objective; }
            set { this._objective = value; }
        }

        // Check to see if Objective property is set
        internal bool IsSetObjective()
        {
            return this._objective != null;
        }

    }
}