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
    /// <para> A complex type that describes the Amazon S3 bucket or the HTTP server (for example, a web server) from which CloudFront gets your
    /// files.You must create at least one origin. </para>
    /// </summary>
    public class Origin  
    {
        
        private string id;
        private string domainName;
        private S3OriginConfig s3OriginConfig;
        private CustomOriginConfig customOriginConfig;

        /// <summary>
        /// A unique identifier for the origin. The value of Id must be unique within the distribution. You use the value of Id when you create a cache
        /// behavior. The Id identifies the origin that CloudFront routes a request to when the request matches the path pattern for that cache
        /// behavior.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public Origin WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;       
        }

        /// <summary>
        /// Amazon S3 origins: The DNS name of the Amazon S3 bucket from which you want CloudFront to get objects for this origin, for example,
        /// myawsbucket.s3.amazonaws.com. Custom origins: The DNS domain name for the HTTP server from which you want CloudFront to get objects for this
        /// origin, for example, www.example.com.
        ///  
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        public Origin WithDomainName(string domainName)
        {
            this.domainName = domainName;
            return this;
        }
            

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;       
        }

        /// <summary>
        /// A complex type that contains information about the Amazon S3 origin. If the origin is a custom origin, use the CustomOriginConfig element
        /// instead.
        ///  
        /// </summary>
        public S3OriginConfig S3OriginConfig
        {
            get { return this.s3OriginConfig; }
            set { this.s3OriginConfig = value; }
        }

        /// <summary>
        /// Sets the S3OriginConfig property
        /// </summary>
        /// <param name="s3OriginConfig">The value to set for the S3OriginConfig property </param>
        /// <returns>this instance</returns>
        public Origin WithS3OriginConfig(S3OriginConfig s3OriginConfig)
        {
            this.s3OriginConfig = s3OriginConfig;
            return this;
        }
            

        // Check to see if S3OriginConfig property is set
        internal bool IsSetS3OriginConfig()
        {
            return this.s3OriginConfig != null;       
        }

        /// <summary>
        /// A complex type that contains information about a custom origin. If the origin is an Amazon S3 bucket, use the S3OriginConfig element
        /// instead.
        ///  
        /// </summary>
        public CustomOriginConfig CustomOriginConfig
        {
            get { return this.customOriginConfig; }
            set { this.customOriginConfig = value; }
        }

        /// <summary>
        /// Sets the CustomOriginConfig property
        /// </summary>
        /// <param name="customOriginConfig">The value to set for the CustomOriginConfig property </param>
        /// <returns>this instance</returns>
        public Origin WithCustomOriginConfig(CustomOriginConfig customOriginConfig)
        {
            this.customOriginConfig = customOriginConfig;
            return this;
        }
            

        // Check to see if CustomOriginConfig property is set
        internal bool IsSetCustomOriginConfig()
        {
            return this.customOriginConfig != null;       
        }
    }
}
