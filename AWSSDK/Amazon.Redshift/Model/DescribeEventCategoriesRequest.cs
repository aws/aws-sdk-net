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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventCategories operation.
    /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
    /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html" >Amazon Redshift Event
    /// Notifications</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DescribeEventCategories"/>
    public class DescribeEventCategoriesRequest : AmazonWebServiceRequest
    {
        private string sourceType;

        /// <summary>
        /// The source type, such as cluster or parameter group, to which the described event categories apply. Valid values: cluster, snapshot,
        /// parameter group, and security group.
        ///  
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventCategoriesRequest WithSourceType(string sourceType)
        {
            this.sourceType = sourceType;
            return this;
        }
            

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;
        }
    }
}
    
