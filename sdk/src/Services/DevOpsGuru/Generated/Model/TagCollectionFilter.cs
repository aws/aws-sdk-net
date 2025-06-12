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
    /// A collection of Amazon Web Services tags used to filter insights. This is used to
    /// return insights generated from only resources that contain the tags in the tag collection.
    /// </summary>
    public partial class TagCollectionFilter
    {
        private string _appBoundaryKey;
        private List<string> _tagValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property TagValues. 
        /// <para>
        /// The values in an Amazon Web Services tag collection.
        /// </para>
        ///  
        /// <para>
        /// The tag's <i>value</i> is an optional field used to associate a string with the tag
        /// <i>key</i> (for example, <c>111122223333</c>, <c>Production</c>, or a team name).
        /// The <i>key</i> and <i>value</i> are the tag's <i>key</i> pair. Omitting the tag <i>value</i>
        /// is the same as using an empty string. Like tag <i>keys</i>, tag <i>values</i> are
        /// case-sensitive. You can specify a maximum of 256 characters for a tag value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && (this._tagValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}