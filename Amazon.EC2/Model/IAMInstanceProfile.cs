/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Part of a request to launch Amazon EC2 instances,
    ///specifying which IAM Instance Profile to use if a profile should be
    ///attached to the new Amazon EC2 instance.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class IAMInstanceProfile
    {    
        private string arnField;
        private string idField;

        /// <summary>
        /// Gets and sets the Arn property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Arn")]
        public string Arn
        {
            get { return this.arnField; }
            set { this.arnField = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">IAM Instance Profile to use if a profile should be
        /// attached to the new Amazon EC2 instance.</param>
        /// <returns>this instance</returns>
        public IAMInstanceProfile WithArn(string arn)
        {
            this.arnField = arn;
            return this;
        }

        /// <summary>
        /// Checks if Arn property is set
        /// </summary>
        /// <returns>true if Arn property is set</returns>
        public bool IsSetArn()
        {
            return this.arnField != null;
        }


        /// <summary>
        /// Gets and sets the Id property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">IAM Instance Profile to use if a profile should be
        /// attached to the new Amazon EC2 instance.</param>
        /// <returns>this instance</returns>
        public IAMInstanceProfile WithId(string id)
        {
            this.idField = id;
            return this;
        }

        /// <summary>
        /// Checks if Arn property is set
        /// </summary>
        /// <returns>true if Arn property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

    }
}
