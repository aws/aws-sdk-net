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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about the Systems Manager automation document that will be used as a runbook
    /// during an incident.
    /// </summary>
    public partial class SsmAutomation
    {
        private string _documentName;
        private string _documentVersion;
        private Dictionary<string, DynamicSsmParameterValue> _dynamicParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, DynamicSsmParameterValue>() : null;
        private Dictionary<string, List<string>> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _roleArn;
        private SsmTargetAccount _targetAccount;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The automation document's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The automation document's version to use when running.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicParameters. 
        /// <para>
        /// The key-value pair to resolve dynamic parameter values when processing a Systems Manager
        /// Automation runbook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, DynamicSsmParameterValue> DynamicParameters
        {
            get { return this._dynamicParameters; }
            set { this._dynamicParameters = value; }
        }

        // Check to see if DynamicParameters property is set
        internal bool IsSetDynamicParameters()
        {
            return this._dynamicParameters != null && (this._dynamicParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value pair parameters to use when running the automation document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that the automation document will assume
        /// when running commands.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The account that the automation document will be run in. This can be in either the
        /// management account or an application account.
        /// </para>
        /// </summary>
        public SsmTargetAccount TargetAccount
        {
            get { return this._targetAccount; }
            set { this._targetAccount = value; }
        }

        // Check to see if TargetAccount property is set
        internal bool IsSetTargetAccount()
        {
            return this._targetAccount != null;
        }

    }
}