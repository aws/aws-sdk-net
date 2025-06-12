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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure for an integration that writes data into a resource.
    /// </summary>
    public partial class InboundIntegration
    {
        private DateTime? _createTime;
        private List<IntegrationError> _errors = AWSConfigs.InitializeCollections ? new List<IntegrationError>() : null;
        private string _integrationArn;
        private IntegrationConfig _integrationConfig;
        private string _sourceArn;
        private IntegrationStatus _status;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the integration was created, in UTC.
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
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors associated with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegrationError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The ARN of the zero-ETL integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationConfig. 
        /// <para>
        /// Properties associated with the integration.
        /// </para>
        /// </summary>
        public IntegrationConfig IntegrationConfig
        {
            get { return this._integrationConfig; }
            set { this._integrationConfig = value; }
        }

        // Check to see if IntegrationConfig property is set
        internal bool IsSetIntegrationConfig()
        {
            return this._integrationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the source resource for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The possible statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING: The integration is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE: The integration creation succeeds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MODIFYING: The integration is being modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED: The integration creation fails. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING: The integration is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYNCING: The integration is synchronizing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NEEDS_ATTENTION: The integration needs attention, such as synchronization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN of the target resource for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}