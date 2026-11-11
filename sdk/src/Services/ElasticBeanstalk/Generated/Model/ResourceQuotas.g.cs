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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A set of per-resource Elastic Beanstalk quotas associated with an Amazon Web Services
    /// account. They reflect Elastic Beanstalk resource limits for this account.
    /// </summary>
    public partial class ResourceQuotas
    {
        /// <summary>
        /// Gets and sets the property ApplicationQuota. 
        /// <para>
        /// The quota for applications in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceQuota ApplicationQuota { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationQuota property is set.
        /// </summary>
        internal bool IsSetApplicationQuota() => this.ApplicationQuota != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionQuota. 
        /// <para>
        /// The quota for application versions in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceQuota ApplicationVersionQuota { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionQuota property is set.
        /// </summary>
        internal bool IsSetApplicationVersionQuota() => this.ApplicationVersionQuota != null;

        /// <summary>
        /// Gets and sets the property ConfigurationTemplateQuota. 
        /// <para>
        /// The quota for configuration templates in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceQuota ConfigurationTemplateQuota { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationTemplateQuota property is set.
        /// </summary>
        internal bool IsSetConfigurationTemplateQuota() => this.ConfigurationTemplateQuota != null;

        /// <summary>
        /// Gets and sets the property CustomPlatformQuota. 
        /// <para>
        /// The quota for custom platforms in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceQuota CustomPlatformQuota { get; set; }

        /// <summary>
        /// Checks to see if the CustomPlatformQuota property is set.
        /// </summary>
        internal bool IsSetCustomPlatformQuota() => this.CustomPlatformQuota != null;

        /// <summary>
        /// Gets and sets the property EnvironmentQuota. 
        /// <para>
        /// The quota for environments in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceQuota EnvironmentQuota { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentQuota property is set.
        /// </summary>
        internal bool IsSetEnvironmentQuota() => this.EnvironmentQuota != null;
    }
}
