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

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    /// <summary>
    /// Interface for unmarshallers which unmarshall objects from response data.
    /// The Unmarshallers are stateless, and only encode the rules for what data
    /// in the Cbor stream goes into what members of an object.
    /// </summary>
    /// <typeparam name="T">The type of object the unmarshaller returns</typeparam>
    /// <typeparam name="TCborUnmarshallerContext">The type of the Cbor unmashaller context,
    /// which contains the state during parsing of the Cbor stream.</typeparam>
    public interface ICborUnmarshaller<T, TCborUnmarshallerContext>
    {
        T Unmarshall(TCborUnmarshallerContext input);
    }
}
