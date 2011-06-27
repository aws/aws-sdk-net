/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Storage
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class Storage
    {    
        private S3Storage s3Field;

        /// <summary>
        /// Gets and sets the S3 property.
        /// S3 Storage
        /// </summary>
        [XmlElementAttribute(ElementName = "S3")]
        public S3Storage S3
        {
            get { return this.s3Field; }
            set { this.s3Field = value; }
        }

        /// <summary>
        /// Sets the S3 property
        /// </summary>
        /// <param name="s3">S3 Storage</param>
        /// <returns>this instance</returns>
        public Storage WithS3(S3Storage s3)
        {
            this.s3Field = s3;
            return this;
        }

        /// <summary>
        /// Checks if S3 property is set
        /// </summary>
        /// <returns>true if S3 property is set</returns>
        public bool IsSetS3()
        {
            return this.s3Field != null;
        }

    }
}
