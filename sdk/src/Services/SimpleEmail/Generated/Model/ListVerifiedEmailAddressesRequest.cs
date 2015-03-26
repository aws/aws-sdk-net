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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ListVerifiedEmailAddresses operation.
    /// Returns a list containing all of the email addresses that have been verified.
    /// 
    ///         <important>The ListVerifiedEmailAddresses action is deprecated as of the May
    /// 15, 2012 release of         Domain Verification. The ListIdentities action is now
    /// preferred.</important>        
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class ListVerifiedEmailAddressesRequest : AmazonSimpleEmailServiceRequest
    {

    }
}