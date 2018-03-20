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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A set of per-resource AWS Elastic Beanstalk quotas associated with an AWS account.
    /// They reflect Elastic Beanstalk resource limits for this account.
    /// </summary>
    public partial class ResourceQuotas
    {
        private ResourceQuota _applicationQuota;
        private ResourceQuota _applicationVersionQuota;
        private ResourceQuota _configurationTemplateQuota;
        private ResourceQuota _customPlatformQuota;
        private ResourceQuota _environmentQuota;

        /// <summary>
        /// Gets and sets the property ApplicationQuota. 
        /// <para>
        /// The quota for applications in the AWS account.
        /// </para>
        /// </summary>
        public ResourceQuota ApplicationQuota
        {
            get { return this._applicationQuota; }
            set { this._applicationQuota = value; }
        }

        // Check to see if ApplicationQuota property is set
        internal bool IsSetApplicationQuota()
        {
            return this._applicationQuota != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionQuota. 
        /// <para>
        /// The quota for application versions in the AWS account.
        /// </para>
        /// </summary>
        public ResourceQuota ApplicationVersionQuota
        {
            get { return this._applicationVersionQuota; }
            set { this._applicationVersionQuota = value; }
        }

        // Check to see if ApplicationVersionQuota property is set
        internal bool IsSetApplicationVersionQuota()
        {
            return this._applicationVersionQuota != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationTemplateQuota. 
        /// <para>
        /// The quota for configuration templates in the AWS account.
        /// </para>
        /// </summary>
        public ResourceQuota ConfigurationTemplateQuota
        {
            get { return this._configurationTemplateQuota; }
            set { this._configurationTemplateQuota = value; }
        }

        // Check to see if ConfigurationTemplateQuota property is set
        internal bool IsSetConfigurationTemplateQuota()
        {
            return this._configurationTemplateQuota != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPlatformQuota. 
        /// <para>
        /// The quota for custom platforms in the AWS account.
        /// </para>
        /// </summary>
        public ResourceQuota CustomPlatformQuota
        {
            get { return this._customPlatformQuota; }
            set { this._customPlatformQuota = value; }
        }

        // Check to see if CustomPlatformQuota property is set
        internal bool IsSetCustomPlatformQuota()
        {
            return this._customPlatformQuota != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentQuota. 
        /// <para>
        /// The quota for environments in the AWS account.
        /// </para>
        /// </summary>
        public ResourceQuota EnvironmentQuota
        {
            get { return this._environmentQuota; }
            set { this._environmentQuota = value; }
        }

        // Check to see if EnvironmentQuota property is set
        internal bool IsSetEnvironmentQuota()
        {
            return this._environmentQuota != null;
        }

    }
}