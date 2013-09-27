/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for a EstimateTemplateCost action.</para>
    /// </summary>
    public class EstimateTemplateCostResult
    {
        
        private string url;

        /// <summary>
        /// An AWS Simple Monthly Calculator URL with a query string that describes the resources required to run the template.
        ///  
        /// </summary>
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }

        /// <summary>
        /// Sets the Url property
        /// </summary>
        /// <param name="url">The value to set for the Url property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EstimateTemplateCostResult WithUrl(string url)
        {
            this.url = url;
            return this;
        }
            

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this.url != null;
        }
    }
}
