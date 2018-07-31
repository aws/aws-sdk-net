/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountAuditConfiguration operation.
    /// </summary>
    public partial class DescribeAccountAuditConfigurationResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, AuditCheckConfiguration> _auditCheckConfigurations = new Dictionary<string, AuditCheckConfiguration>();
        private Dictionary<string, AuditNotificationTarget> _auditNotificationTargetConfigurations = new Dictionary<string, AuditNotificationTarget>();
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AuditCheckConfigurations. 
        /// <para>
        /// Which audit checks are enabled and disabled for this account.
        /// </para>
        /// </summary>
        public Dictionary<string, AuditCheckConfiguration> AuditCheckConfigurations
        {
            get { return this._auditCheckConfigurations; }
            set { this._auditCheckConfigurations = value; }
        }

        // Check to see if AuditCheckConfigurations property is set
        internal bool IsSetAuditCheckConfigurations()
        {
            return this._auditCheckConfigurations != null && this._auditCheckConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuditNotificationTargetConfigurations. 
        /// <para>
        /// Information about the targets to which audit notifications are sent for this account.
        /// </para>
        /// </summary>
        public Dictionary<string, AuditNotificationTarget> AuditNotificationTargetConfigurations
        {
            get { return this._auditNotificationTargetConfigurations; }
            set { this._auditNotificationTargetConfigurations = value; }
        }

        // Check to see if AuditNotificationTargetConfigurations property is set
        internal bool IsSetAuditNotificationTargetConfigurations()
        {
            return this._auditNotificationTargetConfigurations != null && this._auditNotificationTargetConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to AWS IoT to access information about
        /// your devices, policies, certificates and other items as necessary when performing
        /// an audit.
        /// </para>
        ///  
        /// <para>
        /// On the first call to <code>UpdateAccountAuditConfiguration</code> this parameter is
        /// required.
        /// </para>
        /// </summary>
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

    }
}