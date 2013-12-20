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
    /// <para> A complex type that identifies ways in which you want to restrict distribution of your content. </para>
    /// </summary>
    public class Restrictions
    {
        
        private GeoRestriction geoRestriction;


        /// <summary>
        /// A complex type that controls the countries in which your content is distributed. For more information about geo restriction, go to
        /// Customizing Error Responses in the Amazon CloudFront Developer Guide. CloudFront determines the location of your users using MaxMind GeoIP
        /// databases. For information about the accuracy of these databases, see How accurate are your GeoIP databases? on the MaxMind website.
        ///  
        /// </summary>
        public GeoRestriction GeoRestriction
        {
            get { return this.geoRestriction; }
            set { this.geoRestriction = value; }
        }

        // Check to see if GeoRestriction property is set
        internal bool IsSetGeoRestriction()
        {
            return this.geoRestriction != null;
        }
    }
}
