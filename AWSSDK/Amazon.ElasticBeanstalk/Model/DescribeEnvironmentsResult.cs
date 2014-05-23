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
    /// Result message containing a list of environment descriptions.
    /// </summary>
    public partial class DescribeEnvironmentsResult
    {
        private List<EnvironmentDescription> _environments = new List<EnvironmentDescription>();


        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        ///          Returns an <a>EnvironmentDescription</a> list.      
        /// </para>
        /// </summary>
        public List<EnvironmentDescription> Environments
        {
            get { return this._environments; }
            set { this._environments = value; }
        }

        /// <summary>
        /// Sets the Environments property
        /// </summary>
        /// <param name="environments">The values to add to the Environments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsResult WithEnvironments(params EnvironmentDescription[] environments)
        {
            foreach (var element in environments)
            {
                this._environments.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Environments property
        /// </summary>
        /// <param name="environments">The values to add to the Environments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsResult WithEnvironments(IEnumerable<EnvironmentDescription> environments)
        {
            foreach (var element in environments)
            {
                this._environments.Add(element);
            }
            return this;
        }
        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this._environments != null && this._environments.Count > 0; 
        }

    }
}