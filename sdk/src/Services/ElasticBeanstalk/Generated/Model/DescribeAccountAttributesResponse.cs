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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountAttributes operation.
    /// </summary>
    public partial class DescribeAccountAttributesResponse : AmazonWebServiceResponse
    {
        private ResourceQuotas _resourceQuotas;

        /// <summary>
        /// Gets and sets the property ResourceQuotas. 
        /// <para>
        /// The Elastic Beanstalk resource quotas associated with the calling AWS account.
        /// </para>
        /// </summary>
        public ResourceQuotas ResourceQuotas
        {
            get { return this._resourceQuotas; }
            set { this._resourceQuotas = value; }
        }

        // Check to see if ResourceQuotas property is set
        internal bool IsSetResourceQuotas()
        {
            return this._resourceQuotas != null;
        }

    }
}