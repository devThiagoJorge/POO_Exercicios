using Exercicio1.Classes;
using Exercicio1.Exercicio.Classes;
using System;
using Xunit;

namespace Exercicio1Testes.DomainTestes
{
    public class CarroTests
    {
        [Fact(DisplayName = "Acelerar carro")]
        public void Carro_AcelararCarro_DeveAumentarAVelocidadeDoCarro()
        {
            // Arrange
            var endereco = new Endereco("Rua", "Bairro", "Cidade", "Estado", "Cep", "Complemento");
            var proprietario = new Proprietario("Thiago Jorge", "4898965151", "48965459654-XX", endereco);
            var marca = new Marca("Chevrolet", 2, DateTime.Now, Guid.NewGuid());
            var carro = new Carro("Prisma", "Cinza", 2012, marca, "123456789ABCDEFG", 
                proprietario, 100, 20, 4, false, 5, false, 44);

            // Act
            carro.Acelera();

            // Assert
            Assert.Equal(21, carro.VelocidadeAtual);
        }

        [Fact(DisplayName = "Freiar o carro")]
        public void Carro_FreiarCarro_DevePararOCarro()
        {
            // Arrange
            var endereco = new Endereco("Rua", "Bairro", "Cidade", "Estado", "Cep", "Complemento");
            var proprietario = new Proprietario("Thiago Jorge", "4898965151", "48965459654-XX", endereco);

            var marca = new Marca("Chevrolet", 2, DateTime.Now, Guid.NewGuid());
            var carro = new Carro("Prisma", "Cinza", 2012, marca, "123456789ABCDEFG",
                proprietario, 100, 20, 4, false, 5, false, 44);

            // Act
            carro.Freiar();

            // Assert
            Assert.Equal(0, carro.VelocidadeAtual);
        }

        [Fact(DisplayName = "Trocar a marcha")]
        public void Carro_TrocarMarcar_DeveTrocarMarcha()
        {
            // Arrange
            var endereco = new Endereco("Rua", "Bairro", "Cidade", "Estado", "Cep", "Complemento");
            var proprietario = new Proprietario("Thiago Jorge", "4898965151", "48965459654-XX", endereco);

            var marca = new Marca("Chevrolet", 2, DateTime.Now, Guid.NewGuid());
            var carro = new Carro("Prisma", "Cinza", 2012, marca, "123456789ABCDEFG",
                proprietario, 100, 20, 4, false, 5, false, 44);

            // Act && // Assert
            Assert.Throws<DomainException>(() => carro.TrocarMarcha(1));
        }

        [Fact(DisplayName = "Trocar a marcha para ré com velocidade = 0")]
        public void Carro_TrocarMarcar_NaoDeveTrocarMarcha()
        {
            // Arrange
            var endereco = new Endereco("Rua", "Bairro", "Cidade", "Estado", "Cep", "Complemento");
            var proprietario = new Proprietario("Thiago Jorge", "4898965151", "48965459654-XX", endereco);

            var marca = new Marca("Chevrolet", 2, DateTime.Now, Guid.NewGuid());
            var carro = new Carro("Prisma", "Cinza", 2012, marca, "123456789ABCDEFG",
                proprietario, 100, 20, 4, false, 5, false, 44);

            var marcha = 0;
            // Act && // Assert
            Assert.Throws<DomainException>(() => carro.TrocarMarcha(marcha));
        }

        [Fact(DisplayName = "Reduzir a marcha")]
        public void Carro_ReduzirAMarcha_DeveReduzirAMarcha()
        {
            // Arrange
            var endereco = new Endereco("Rua", "Bairro", "Cidade", "Estado", "Cep", "Complemento");
            var proprietario = new Proprietario("Thiago Jorge", "4898965151", "48965459654-XX", endereco);

            var marca = new Marca("Chevrolet", 2, DateTime.Now, Guid.NewGuid());
            var carro = new Carro("Prisma", "Cinza", 2012, marca, "123456789ABCDEFG",
                proprietario, 100, 20, 4, false, 5, false, 44);

            // Act && // Assert
            Assert.Throws<DomainException>(() => carro.ReduzirMarcha());
        }

    }


}
