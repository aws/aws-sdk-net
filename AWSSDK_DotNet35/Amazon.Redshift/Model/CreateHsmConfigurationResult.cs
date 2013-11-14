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
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The results from the CreateHsmConfiguration action.
    /// </summary>
    public partial class CreateHsmConfigurationResult : AmazonWebServiceResponse
    {
        private HsmConfiguration hsmConfigurationValue;

        /// <summary>
        /// Gets and sets the CreateHsmConfigurationResult property.
        /// Contains the result of a successful invocation of the CreateHsmConfiguration
        /// action.
        /// </summary>
        public HsmConfiguration HsmConfiguration
        {
            get { return this.hsmConfigurationValue; }
            set { this.hsmConfigurationValue = value; }
        }
    }
}
    
