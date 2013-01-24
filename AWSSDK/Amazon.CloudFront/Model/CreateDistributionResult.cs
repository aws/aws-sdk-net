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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The returned result of the corresponding request. </para>
    /// </summary>
    public class CreateDistributionResult  
    {
        
        private Distribution distribution;
        private string location;
        private string eTag;

        /// <summary>
        /// The distribution's information.
        ///  
        /// </summary>
        public Distribution Distribution
        {
            get { return this.distribution; }
            set { this.distribution = value; }
        }

        /// <summary>
        /// Sets the Distribution property
        /// </summary>
        /// <param name="distribution">The value to set for the Distribution property </param>
        /// <returns>this instance</returns>
        public CreateDistributionResult WithDistribution(Distribution distribution)
        {
            this.distribution = distribution;
            return this;
        }
            

        // Check to see if Distribution property is set
        internal bool IsSetDistribution()
        {
            return this.distribution != null;       
        }

        /// <summary>
        /// The fully qualified URI of the new distribution resource just created. For example:
        /// https://cloudfront.amazonaws.com/2010-11-01/distribution/EDFDVBD632BHDS5.
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        public CreateDistributionResult WithLocation(string location)
        {
            this.location = location;
            return this;
        }
            

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;       
        }

        /// <summary>
        /// The current version of the distribution created.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Sets the ETag property
        /// </summary>
        /// <param name="eTag">The value to set for the ETag property </param>
        /// <returns>this instance</returns>
        public CreateDistributionResult WithETag(string eTag)
        {
            this.eTag = eTag;
            return this;
        }
            

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;       
        }
    }
}
