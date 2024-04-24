/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rest-xml-protocol-namespace-2019-12-16.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestXmlProtocolNamespace.Model;

#pragma warning disable CS1570
namespace Amazon.RestXmlProtocolNamespace
{
    /// <summary>
    /// <para>Interface for accessing RestXmlProtocolNamespace</para>
    ///
    /// A REST XML service that sends XML requests and responses.
    /// 
    ///  
    /// <para>
    /// This service and test case is complementary to the test cases in the <c>restXml</c>
    /// directory, but the service under test here has the <c>xmlNamespace</c> trait applied
    /// to it.
    /// </para>
    ///  
    /// <para>
    /// See https://github.com/awslabs/smithy/issues/616
    /// </para>
    /// </summary>
    public partial interface IAmazonRestXmlProtocolNamespace : IAmazonService, IDisposable
    {




        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocolNamespace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-namespace-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonRestXmlProtocolNamespaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-namespace-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        IAsyncResult BeginSimpleScalarProperties(SimpleScalarPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarPropertiesResult from RestXmlProtocolNamespace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-namespace-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult);

        #endregion
        
    }
}