/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityToken.Model
{
    /// <summary>Federated User
    /// </summary>
    public class FederatedUser  
    {
        
        private string federatedUserId;
        private string arn;
        public string FederatedUserId
        {
            get { return this.federatedUserId; }
            set { this.federatedUserId = value; }
        }

        /// <summary>
        /// Sets the FederatedUserId property
        /// </summary>
        /// <param name="federatedUserId">The value to set for the FederatedUserId property </param>
        /// <returns>this instance</returns>
        public FederatedUser WithFederatedUserId(string federatedUserId)
        {
            this.federatedUserId = federatedUserId;
            return this;
        }
            

        // Check to see if FederatedUserId property is set
        internal bool IsSetFederatedUserId()
        {
            return this.federatedUserId != null;       
        }
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        public FederatedUser WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;       
        }
    }
}
