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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Returns information about the  DeleteHostedZone response and response metadata.
    /// </summary>
    public class DeleteHostedZoneResponse : DeleteHostedZoneResult
    {
        /// <summary>
        /// Gets and sets the DeleteHostedZoneResult property.
        /// A complex type containing the response information for the request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DeleteHostedZoneResult class are now available on the DeleteHostedZoneResponse class. You should use the properties on DeleteHostedZoneResponse instead of accessing them through DeleteHostedZoneResult.")]
        public DeleteHostedZoneResult DeleteHostedZoneResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
