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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the GetConfigurationPolicy operation.
    /// </summary>
    public partial class GetConfigurationPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the configuration policy. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicy. 
        /// <para>
        ///  An object that defines how Security Hub CSPM is configured. It includes whether Security
        /// Hub CSPM is enabled or disabled, a list of enabled security standards, a list of enabled
        /// or disabled security controls, and a list of custom parameter values for specified
        /// controls. If the policy includes a list of security controls that are enabled, Security
        /// Hub CSPM disables all other controls (including newly released controls). If the policy
        /// includes a list of security controls that are disabled, Security Hub CSPM enables
        /// all other controls (including newly released controls). 
        /// </para>
        /// </summary>
        public Policy ConfigurationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationPolicy property is set.
        /// </summary>
        internal bool IsSetConfigurationPolicy() => this.ConfigurationPolicy != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The date and time, in UTC and ISO 8601 format, that the configuration policy was
        /// created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the configuration policy. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The UUID of the configuration policy. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the configuration policy. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The date and time, in UTC and ISO 8601 format, that the configuration policy was
        /// last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
