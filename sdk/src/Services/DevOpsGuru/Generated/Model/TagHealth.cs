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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the health of Amazon Web Services resources in your account that
    /// are specified by an Amazon Web Services tag <i>key</i>.
    /// </summary>
    public partial class TagHealth
    {
        private long? _analyzedResourceCount;
        private string _appBoundaryKey;
        private InsightHealth _insight;
        private string _tagValue;

        /// <summary>
        /// Gets and sets the property AnalyzedResourceCount. 
        /// <para>
        ///  Number of resources that DevOps Guru is monitoring in your account that are specified
        /// by an Amazon Web Services tag. 
        /// </para>
        /// </summary>
        public long? AnalyzedResourceCount
        {
            get { return this._analyzedResourceCount; }
            set { this._analyzedResourceCount = value; }
        }

        // Check to see if AnalyzedResourceCount property is set
        internal bool IsSetAnalyzedResourceCount()
        {
            return this._analyzedResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppBoundaryKey. 
        /// <para>
        /// An Amazon Web Services tag <i>key</i> that is used to identify the Amazon Web Services
        /// resources that DevOps Guru analyzes. All Amazon Web Services resources in your account
        /// and Region tagged with this <i>key</i> make up your DevOps Guru application and analysis
        /// boundary.
        /// </para>
        ///  <important> 
        /// <para>
        /// The string used for a <i>key</i> in a tag that you use to define your resource coverage
        /// must begin with the prefix <c>Devops-guru-</c>. The tag <i>key</i> might be <c>DevOps-Guru-deployment-application</c>
        /// or <c>devops-guru-rds-application</c>. When you create a <i>key</i>, the case of characters
        /// in the <i>key</i> can be whatever you choose. After you create a <i>key</i>, it is
        /// case-sensitive. For example, DevOps Guru works with a <i>key</i> named <c>devops-guru-rds</c>
        /// and a <i>key</i> named <c>DevOps-Guru-RDS</c>, and these act as two different <i>keys</i>.
        /// Possible <i>key</i>/<i>value</i> pairs in your application might be <c>Devops-Guru-production-application/RDS</c>
        /// or <c>Devops-Guru-production-application/containers</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AppBoundaryKey
        {
            get { return this._appBoundaryKey; }
            set { this._appBoundaryKey = value; }
        }

        // Check to see if AppBoundaryKey property is set
        internal bool IsSetAppBoundaryKey()
        {
            return this._appBoundaryKey != null;
        }

        /// <summary>
        /// Gets and sets the property Insight. 
        /// <para>
        /// Information about the health of the Amazon Web Services resources in your account
        /// that are specified by an Amazon Web Services tag, including the number of open proactive,
        /// open reactive insights, and the Mean Time to Recover (MTTR) of closed insights. 
        /// </para>
        /// </summary>
        public InsightHealth Insight
        {
            get { return this._insight; }
            set { this._insight = value; }
        }

        // Check to see if Insight property is set
        internal bool IsSetInsight()
        {
            return this._insight != null;
        }

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The value in an Amazon Web Services tag.
        /// </para>
        ///  
        /// <para>
        /// The tag's <i>value</i> is an optional field used to associate a string with the tag
        /// <i>key</i> (for example, <c>111122223333</c>, <c>Production</c>, or a team name).
        /// The <i>key</i> and <i>value</i> are the tag's <i>key</i> pair. Omitting the tag <i>value</i>
        /// is the same as using an empty string. Like tag <i>keys</i>, tag <i>values</i> are
        /// case-sensitive. You can specify a maximum of 256 characters for a tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }

        // Check to see if TagValue property is set
        internal bool IsSetTagValue()
        {
            return this._tagValue != null;
        }

    }
}