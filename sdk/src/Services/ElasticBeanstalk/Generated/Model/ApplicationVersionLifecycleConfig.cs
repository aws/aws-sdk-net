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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// The application version lifecycle settings for an application. Defines the rules that
    /// Elastic Beanstalk applies to an application's versions in order to avoid hitting the
    /// per-region limit for application versions.
    /// 
    ///  
    /// <para>
    /// When Elastic Beanstalk deletes an application version from its database, you can no
    /// longer deploy that version to an environment. The source bundle remains in S3 unless
    /// you configure the rule to delete it.
    /// </para>
    /// </summary>
    public partial class ApplicationVersionLifecycleConfig
    {
        private MaxAgeRule _maxAgeRule;
        private MaxCountRule _maxCountRule;

        /// <summary>
        /// Gets and sets the property MaxAgeRule. 
        /// <para>
        /// Specify a max age rule to restrict the length of time that application versions are
        /// retained for an application.
        /// </para>
        /// </summary>
        public MaxAgeRule MaxAgeRule
        {
            get { return this._maxAgeRule; }
            set { this._maxAgeRule = value; }
        }

        // Check to see if MaxAgeRule property is set
        internal bool IsSetMaxAgeRule()
        {
            return this._maxAgeRule != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCountRule. 
        /// <para>
        /// Specify a max count rule to restrict the number of application versions that are retained
        /// for an application.
        /// </para>
        /// </summary>
        public MaxCountRule MaxCountRule
        {
            get { return this._maxCountRule; }
            set { this._maxCountRule = value; }
        }

        // Check to see if MaxCountRule property is set
        internal bool IsSetMaxCountRule()
        {
            return this._maxCountRule != null;
        }

    }
}