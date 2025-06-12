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
    /// Container for the parameters to the DescribeEnvironmentHealth operation.
    /// Returns information about the overall health of the specified environment. The <b>DescribeEnvironmentHealth</b>
    /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
    /// </summary>
    public partial class DescribeEnvironmentHealthRequest : AmazonElasticBeanstalkRequest
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _environmentId;
        private string _environmentName;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// Specify the response elements to return. To retrieve all attributes, set to <c>All</c>.
        /// If no attribute names are specified, returns the name of the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// Specify the environment by ID.
        /// </para>
        ///  
        /// <para>
        /// You must specify either this or an EnvironmentName, or both.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// Specify the environment by name.
        /// </para>
        ///  
        /// <para>
        /// You must specify either this or an EnvironmentName, or both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

    }
}