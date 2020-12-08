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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// An entity that defines the scope of audit evidence collected by AWS Audit Manager.
    /// An AWS Audit Manager assessment is an implementation of an AWS Audit Manager framework.
    /// </summary>
    public partial class Assessment
    {
        private string _arn;
        private AWSAccount _awsAccount;
        private AssessmentFramework _framework;
        private AssessmentMetadata _metadata;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property AwsAccount. 
        /// <para>
        ///  The AWS account associated with the assessment. 
        /// </para>
        /// </summary>
        public AWSAccount AwsAccount
        {
            get { return this._awsAccount; }
            set { this._awsAccount = value; }
        }

        // Check to see if AwsAccount property is set
        internal bool IsSetAwsAccount()
        {
            return this._awsAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        ///  The framework from which the assessment was created. 
        /// </para>
        /// </summary>
        public AssessmentFramework Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        ///  The metadata for the specified assessment. 
        /// </para>
        /// </summary>
        public AssessmentMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}