// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key Vault container ARM resource for a certificate that is purchased
    /// through Azure.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AppServiceCertificatePatchResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AppServiceCertificatePatchResource class.
        /// </summary>
        public AppServiceCertificatePatchResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AppServiceCertificatePatchResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="keyVaultId">Key Vault resource Id.</param>
        /// <param name="keyVaultSecretName">Key Vault secret name.</param>
        /// <param name="provisioningState">Status of the Key Vault secret.
        /// Possible values include: 'Initialized',
        /// 'WaitingOnCertificateOrder', 'Succeeded', 'CertificateOrderFailed',
        /// 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'</param>
        public AppServiceCertificatePatchResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string keyVaultId = default(string), string keyVaultSecretName = default(string), KeyVaultSecretStatus? provisioningState = default(KeyVaultSecretStatus?))
            : base(id, name, kind, type)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key Vault resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets key Vault secret name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        /// <summary>
        /// Gets status of the Key Vault secret. Possible values include:
        /// 'Initialized', 'WaitingOnCertificateOrder', 'Succeeded',
        /// 'CertificateOrderFailed', 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public KeyVaultSecretStatus? ProvisioningState { get; private set; }

    }
}